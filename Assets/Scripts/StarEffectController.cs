using UnityEngine;

public class StarEffectController : MonoBehaviour
{
    [SerializeField] private bool _isActive;

    private Material _starMaterial;

    private void Start()
    {
        _starMaterial = gameObject.GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        if(_isActive)
        {
            _starMaterial.EnableKeyword("_ISACTIVE_ON");
            _starMaterial.DisableKeyword("_ISACTIVE_OFF");
        }
        else
        {
            _starMaterial.EnableKeyword("_ISACTIVE_OFF");
            _starMaterial.DisableKeyword("_ISACTIVE_ON");
        }
    }
}
