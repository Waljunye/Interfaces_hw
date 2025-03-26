using UnityEngine;

namespace InfimaGames.LowPolyShooterPack
{
    public class ChestScript : MonoBehaviour, IInteractable
    {
        [SerializeField] private int pickupIndex;

        private bool _isOpened;
        public void Interact(CharacterBehaviour character)
        {
            if(_isOpened) return;
        
           character.GetInventory().AddWeapon(pickupIndex);
        
            _isOpened = true;
        }
    }
}
