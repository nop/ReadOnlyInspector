# `[ReadOnlyInspector]` attribute for Unity

This attribute allows you to make any field in the inspector read-only.

**Note:**
This attribute only works in the inspector.
It does not prevent the field from being modified in code.
Use the [`readonly`] keyword for that.

## Usage

Just add the attribute to any field you want to make read-only in the inspector:

```csharp
public class MyComponent : MonoBehaviour
{
	[ReadOnlyInspector] public int myInt;
	[ReadOnlyInspector] public string myString;
	[ReadOnlyInspector] public GameObject myGameObject;
	[ReadOnlyInspector] public MyCustomClass myCustomClass;
	
	[SerializeField, ReadOnlyInspector]
	private int myPrivateInt;
	[SerializeField, ReadOnlyInspector]
	private string myPrivateString;
	[SerializeField, ReadOnlyInspector]
	private GameObject myPrivateGameObject;
	[SerializeField, ReadOnlyInspector]
	private MyCustomClass myPrivateCustomClass;
}
```

[`readonly`]: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly
