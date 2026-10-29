using UnityEngine;

public class Vfx_play : MonoBehaviour
{
    [SerializeField] private GameObject vfxPrefab;

    public void PlayVFX(Vector3 position)
    {
        Instantiate(vfxPrefab, position, Quaternion.identity);
    }

   
}

