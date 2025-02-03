# handsome Alert Messages in C#

## How to Install:
- Add the AlertForm files to your project:

AlertForm.cs

AlertForm.designer.cs

AlertForm.resx

Properties\AlertResources.resx


- Customize the appearance of the Notification form in AlertForm.cs

Color, Size, Icon, Background, ...

### Use AlertForm in your Code:
```csharp
public void Alert(string msgTitle, string msgText, AlertForm.enmType type)
{
    AlertForm frm = new AlertForm();
    frm.showAlert(msgTitle,msgText,type);
}
```
#### to use the AlertForm use the following Syntax:
```csharp
this.Alert("alertTITLE","alertTEXT", AlertForm.enmType.alertTYPE);
```
- Edit **alertTITLE** and **alertTEXT** with your desired title and the corresponding text.
- Edit **alertTYPE** to the desired type (Success, Info, Warning, Error)
