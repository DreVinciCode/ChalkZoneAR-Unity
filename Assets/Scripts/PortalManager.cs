using UnityEngine;
using UnityEngine.Rendering;

public class PortalManager : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Sponza;

    private Material[] _sponzaMaterials;

    private void Start()
    {
        _sponzaMaterials = Sponza.GetComponent<Renderer>().sharedMaterials;
    }

    private void OnTriggerStay(Collider other)
    {
        Vector3 camPositionInPortalSpace = transform.InverseTransformPoint(MainCamera.transform.position);

        if (camPositionInPortalSpace.y < 0.5f)
        {
            //Disable Stencil
            for (int i = 0; i < _sponzaMaterials.Length; i++)
            {
                _sponzaMaterials[i].SetInt("_StencilComp", (int)CompareFunction.Always);
            }
        }
        else
        {
            //Enable Stencil
            for (int i = 0; i < _sponzaMaterials.Length; i++)
            {
                _sponzaMaterials[i].SetInt("_StencilComp", (int)CompareFunction.Equal);
            }
        }
    }
}
