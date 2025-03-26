using UnityEngine;

public interface IHaveProjectileReaction
{
    public void React(Vector3 position, Collision collision);
}