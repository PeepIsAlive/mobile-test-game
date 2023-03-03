using Screens.Views;
using UnityEngine;

namespace Screens.Controllers
{
    public sealed class ActionsScreenController : MonoBehaviour
    {
        [SerializeField] private ActionsScreenView _view;

        private void OnEnable()
        {
            ViewInitialize();
        }

        private void ViewInitialize()
        {
            if (_view == null)
                _view = GetComponent<ActionsScreenView>();
        }
    }
}
