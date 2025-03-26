
using UnityEngine;

namespace InfimaGames.LowPolyShooterPack
{
    public interface IMovable
    {
        public string name { get; }
        public Vector2 GetInputMovement();
    }
}