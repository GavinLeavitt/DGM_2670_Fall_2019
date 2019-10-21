using System.Runtime.InteropServices;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CinemachineController : MonoBehaviour
{
    public GameAction gameActionObject;
    private CinemachineVirtualCamera virtualCamera;

    private void Start()
    {
        gameActionObject.transformAction = TransformHandler;
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void TransformHandler(Transform transformObj)
    {
        virtualCamera.Follow = transformObj;
    }
}
