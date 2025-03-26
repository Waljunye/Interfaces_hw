using UnityEngine;

public class SurfaceParentImpactScript : MonoBehaviour
{
    public Transform[] impactPrefabs;
    void Start()
    {
        foreach (Transform child in transform)
        {
            SurfaceImpactScript surfaceChildImpact = child.gameObject.AddComponent<SurfaceImpactScript>();
            surfaceChildImpact.impactPrefabs = impactPrefabs;
        }   
    }
}
