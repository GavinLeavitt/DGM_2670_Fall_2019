using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Text))]
public class WeaponButtonHandler : MonoBehaviour
{
	public WeaponConfig weaponObj;
	private Button weaponButton;
	private Image buttonImg;
	private Text buttonText;

	private void Start()
	{
		weaponButton = GetComponent<Button>();
		weaponButton.onClick.AddListener(weaponObj.RaiseFireAction);
		buttonImg = GetComponent<Image>();
		buttonImg.color = weaponObj.weaponColor;
		buttonText = GetComponentInChildren<Text>();
		buttonText.text = weaponObj.name + " fire";
		weaponObj.collectWeaponAction = OnCollectWeapon;
		weaponButton.interactable = false;
	}

	public void OnCollectWeapon()
	{
		weaponButton.interactable = true;		
	}
}