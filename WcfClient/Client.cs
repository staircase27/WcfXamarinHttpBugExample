// © Copyright Meyertech Ltd. 2007-2017
// 
// All rights are reserved. Reproduction or transmission in whole or in part, in
// any form or by any means, electronic, mechanical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Solution: WcfHttpsXamarinAndroidTest
// Project: WcfClient
// 
// Last edited by Simon Armstrong:
// 2017 - 02 - 15  @ 16:47


using System;
using System.ComponentModel;
using System.ServiceModel;
using System.Threading.Tasks;
using WcfClient.ServiceReference;

namespace WcfClient
{
    public class Client
    {
        private readonly HelloServiceClient _client;

        public Client(bool useHttps)
        {
            _client =
                new HelloServiceClient(useHttps
                    ? HelloServiceClient.EndpointConfiguration.BasicHttpBinding_IHelloService
                    : HelloServiceClient.EndpointConfiguration.BasicHttpBinding_IHelloService1);
            _client.OpenCompleted += _client_AsyncCompleted;
            _client.CloseCompleted += _client_AsyncCompleted;
            _client.SayHelloCompleted += _client_SayHelloCompleted;
        }

        private static void _client_SayHelloCompleted(object sender, SayHelloCompletedEventArgs e)
        {
            var taskCompletionSource = e.UserState as TaskCompletionSource<string>;
            if (taskCompletionSource == null)
                return;
            if (e.Cancelled)
            {
                taskCompletionSource.SetCanceled();
                return;
            }
            if (e.Error != null)
            {
                taskCompletionSource.SetException(e.Error);
                return;
            }
            taskCompletionSource.TrySetResult(e.Result);
        }

        private static void _client_AsyncCompleted(object sender, AsyncCompletedEventArgs e)
        {
            var taskCompletionSource = e.UserState as TaskCompletionSource<bool>;
            if (taskCompletionSource == null)
                return;
            if (e.Cancelled)
            {
                taskCompletionSource.SetCanceled();
                return;
            }
            if (e.Error != null)
            {
                taskCompletionSource.SetException(e.Error);
                return;
            }
            taskCompletionSource.TrySetResult(true);
        }

        public bool IsOpen => _client.State == CommunicationState.Opened;

        public Task Open()
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            if (IsOpen)
                taskCompletionSource.TrySetResult(false);
            else
                _client.OpenAsync(taskCompletionSource);
            return taskCompletionSource.Task;
        }


        public Task Close()
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            if (_client.State == CommunicationState.Closed || _client.State == CommunicationState.Closing)
                taskCompletionSource.TrySetResult(false);
            else
                _client.CloseAsync(taskCompletionSource);
            return taskCompletionSource.Task;
        }

        public Task<string> SayHello(string name)
        {
            var taskCompletionSource = new TaskCompletionSource<string>();
            if (!IsOpen)
                throw new InvalidOperationException("Client is not open");
            _client.SayHelloAsync(name, taskCompletionSource);
            return taskCompletionSource.Task;
        }

        public string Url => _client.Endpoint.Address.Uri.ToString();
    }
}