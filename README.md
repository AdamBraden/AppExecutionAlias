# AppExecutionAlias
Simple example showing how to call CreateProcess() on an AppExecutionAlias and inherits environment variables

In this sample there are 2 console apps. One is packaged (ConsoleApp6) and is the child process called by the main test process. The test process changes an environment variable, and this is passed onto the child process. The child process is spawned by calling CreateProcess() on its AppExecutionAlias which is defined by the package (in the Package.appxmanifest file of the Windows Application Packaging Project).

Simply clone the repro and build in VS2019+. Deploy the ConsoleApp6.Package. To demo, goto a command prompt and navigate to the CreateProcessTest output folder, and start CreateProcessTest.exe.
