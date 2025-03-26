using UnityEngine;

public class SurfaceImpactScript : MonoBehaviour, IHaveProjectileReaction
{
    public Transform[] impactPrefabs;
    
    public virtual void React(Vector3 position, Collision collision)
    {
        Instantiate (impactPrefabs [Random.Range 
                (0, impactPrefabs.Length)], position, 
            Quaternion.LookRotation (collision.contacts [0].normal));
    }
}
