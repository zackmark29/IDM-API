# IDM-API
Use IDM API in C# without importing .dll

---

`NOTE`: You must have IDM installed in your system.

## USAGE:

```C#
var url = "";
var outputFolder = "";
var outputFilename = "";
var idmFlag = 1;

IIDMApi idm = new IDMApi();
idm.SendLinkToIDM(
    bstrUrl: url ,
    bstrLocalPath: outputFolder,
    bstrLocalFileName: outputFilename
    lFlags: idmFlag,
    bstrReferer: null,
    bstrCookies: null,
    bstrData: null,
    bstrUser: null,
    bstrPassword: null);

```
