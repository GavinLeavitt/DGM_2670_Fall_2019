using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AmmoHandler : MonoBehaviour
{
	private Rigidbody rigidbodyObj;
	public Vector3 forces;
	public WeaponConfig weaponObj;

	private void Start()
	{
		var renderer = GetComponent<Renderer>();
		renderer.material.color = weaponObj.weaponColor;
		rigidbodyObj = GetComponent<Rigidbody>();
		rigidbodyObj.AddForce(forces);
		Destroy(gameObject, 1f);
	}

	private void OnTriggerEnter(Collider other)
	{
		weaponObj.DoDamage();
	}
}