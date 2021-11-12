# Raycast Info
Get Information about the raycast

## Scripts 

### `HitInfoManager.cs`
Shows examples of accessing raycast hit related info.</br>
- Getting JMRPointerObject
```cs
Transform cursorTransform = JMRPointerManager.Instance.GetCursorTransform();
```
- Getting currently focused object
```cs
GameObject go = JMRPointerManager.Instance.GetCurrentFocusedObject();
```
- Getting raycast hit object
```cs
Ray ray = JMRPointerManager.Instance.GetCurrentRay();
if (Physics.Raycast(ray, out RaycastHit hit))
{
}
```

## How to use?
1. Download and unzip this project.
2. Open the project using Unity Hub.
3. Download and import the latest version of JMRSDK package.
4. Open and play the HitInfo scene from Assets/Scenes folder.
