Minimal working example for an issue with connecting an Xamarin app to a WCF service running over https.

There are a few different programs in here to test different cases and methods of connecting.
The main projects that will need to be used directly are:
* WcfServiceConsoleApplication - The program that actually runs the service and hosts it. Make sure to update the ip address in app.config to match the ip address of the machine you are going to run it on.
* TestApp.Droid - The android client.
* WcfConsoleClient - A console client using the same client program

There is also a SoapUI project that shows the service being used. Again remember to update the ip address.

To setup requires a few steps.
 * Firstly run the following commands in a command prompt running as administator:
```
netsh http add urlacl url=http://+:28765/ user=USERNAME
netsh http add urlacl url=https://+:18765/ user=USERNAME
makecert -ss my -n CN=localhost -sk TestApp -sr LocalMachine
netsh http add sslcert ipport=0.0.0.0:26987 certhash=CERTHASH appid={8df592d9-1e89-42f8-956d-68572fe146a5} certstorename=my
```
where USERNAME is replaced with your username and CERTHASH is replaced with the hash of the key created in the previous command.

* Next a firewall rule needs to be added to allow the ports to be accessed remotely. The two ports are 18765 and 28765 and the rule can be added on windows 7 from Control Panel > Window Firewall > Advanced Settings > Inbound Rules > New Rule.

* Update the ip address for the service in App.Config in the project WcfServiceConsoleApplication and then build. 

* Now run the wcf service (WcfServiceConsoleApplication).

* Nex in visual studio open the WcfClient project and right click on the Service Referenece and select "Configure Service Reference" to update the ip address then let it update the service and build all projects.

* The TestApp.Droid project can now be either run on an emulator or archived and distributed to be copied to a android device and installed.

