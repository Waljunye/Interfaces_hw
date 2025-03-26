using TMPro;
using UnityEngine;

namespace InfimaGames.LowPolyShooterPack
{
    
    public class TrunCanvasTextChangeScript: MonoBehaviour, IInteractable, IHaveProjectileReaction
    {
        [SerializeField]
        private TMP_Text textMesh;

        private bool _interacted;
        private bool _shooted;
        public void Interact(CharacterBehaviour character)
        {
            if (_interacted) return;
            textMesh.text += "\nSosal?";
            _interacted = true;
        }

        public void React(Vector3 position, Collision collision)
        {
            if(!_interacted) return;
            if(_shooted) return; 
            textMesh.text += "\n AHAHAHAHAHAH, kakoy zloy";
           _shooted = true; 
        }
    }
}