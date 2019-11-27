using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
	public WeaponConfig weaponObj;

	void Start()
	{
		weaponObj.weaponFireAction = Fire;
		var renderer = GetComponent<Renderer>();
		renderer.material.color = weaponObj.weaponColor;
	}

	public void Fire()
	{
		
		var ammo = Instantiate(weaponObj.ammoObj);
		ammo.GetComponent<AmmoHandler>().weaponObj = weaponObj;
	}

	private void OnTriggerEnter(Collider other)
	{
		weaponObj.RaiseCollectAction();
	}
}