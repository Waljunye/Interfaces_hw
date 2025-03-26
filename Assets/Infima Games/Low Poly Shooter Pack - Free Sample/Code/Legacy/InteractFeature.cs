using InfimaGames.LowPolyShooterPack;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Infima_Games.Low_Poly_Shooter_Pack___Free_Sample.Code.Legacy
{
    public class InteractFeature: MonoBehaviour
    {
        [SerializeField]
        private Camera camera;
        
        [SerializeField]
        private CharacterBehaviour character;

        private void Start()
        {
            if (!camera) camera = Camera.main;
        }

        private void Interact()
        {
            Ray ray = new Ray(camera.transform.position, camera.transform.forward);

            if (Physics.Raycast(ray, out RaycastHit hit, 10f))
            {
                if (hit.collider.gameObject.TryGetComponent(out IInteractable interactable))
                {
                    interactable.Interact(character);
                }
            }
        }
        
        public void OnInteract(InputAction.CallbackContext context)
        {
            switch (context)
            {
                case {performed: true}:
                    Interact();
                    break;
            }
            
        }
    }
}