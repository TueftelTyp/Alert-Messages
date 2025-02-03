# handsome Alert Messages in C#

![demo](https://github.com/TueftelTyp/Alert-Messages/blob/main/demo.png "demo")

## How to Install:
1. Add the Notifications form files to your project:
	- AlertForm.cs
	- AlertForm.designer.cs
	- AlertForm.resx
	- Properties\AlertResources.resx
2. Customize the appearance of the Notification form in AlertForm.cs
	-  Color, Size, Icon, Background, ...
3. Use AlertForm in your Code:
```csharp
public void Alert(string msgTitle, string msgText, AlertForm.enmType type)
{
    AlertForm frm = new AlertForm();
    frm.showAlert(msgTitle,msgText,type);
}
```
4. to use the AlertForm use the following Syntax:
```csharp
this.Alert("alertTITLE","alertTEXT", AlertForm.enmType.alertTYPE);
```
- Edit **alertTITLE** and **alertTEXT** with your desired title and the corresponding text.
    - Also edit **alertTYPE** to the desired type (Success, Info, Warning, Error)
