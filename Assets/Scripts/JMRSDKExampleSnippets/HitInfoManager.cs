using UnityEngine;
using JMRSDK.InputModule;
using TMPro;

namespace JMRSDKExampleSnippets
{
	/// <summary>
	/// Example of accessing raycast hit info
	/// </summary>
	public class HitInfoManager : MonoBehaviour
	{
		[SerializeField] TextMeshProUGUI CursorObjectText;
		[SerializeField] TextMeshProUGUI FocusedObjectText;
		[SerializeField] TextMeshProUGUI HitObjectText;

		/// <summary>
		/// Call all the functions that update info.
		/// </summary>
		public void Update()
		{
			HitObjectInfo();
			FocusedObjectInfo();
			CursorInfo();
		}

		/// <summary>
		/// Get JMRPointerObject and update it on UI.
		/// </summary>
		public void CursorInfo()
		{
			// get cursor transform
			Transform cursorTransform = JMRPointerManager.Instance.GetCursorTransform();
			if (cursorTransform == null)
			{
				CursorObjectText.text = "Cursor Object : null";
			}
			else
			{
				CursorObjectText.text = "Cursor Object : " + cursorTransform.name;
			}
		}

		/// <summary>
		/// Get the currently focused object and update it on UI.
		/// </summary>
		public void FocusedObjectInfo()
		{
			// get current focus
			GameObject go = JMRPointerManager.Instance.GetCurrentFocusedObject();
			if (go == null)
			{
				FocusedObjectText.text = "Focused Object : null";
			}
			else
			{
				FocusedObjectText.text = "Focused Object : " + go.name;
			}
		}

		/// <summary>
		/// Get the currently hit object and update it on UI.
		/// </summary>
		public void HitObjectInfo()
		{
			// get current ray
			Ray ray = JMRPointerManager.Instance.GetCurrentRay();
			if (Physics.Raycast(ray, out RaycastHit hit))
			{
				HitObjectText.text = "Hit Object : " + hit.transform.name;
			}
			else
			{
				HitObjectText.text = "Hit Object : null";
			}
		}
	}
}
