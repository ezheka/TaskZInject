using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Pages
{
    public class Page : MonoBehaviour
    {
        [SerializeField] private Image _imageBackground;
        [SerializeField] private TMP_Text _textContent;
        [Space]
        [SerializeField] private CanvasGroup _canvasGroup;
    
        public void SetInfo(PageInfo pageInfo)
        {
            _imageBackground.color = pageInfo.BackgroundColor;
            _textContent.text = pageInfo.StringContent;
        }

        public void ChangeVisibility(bool isVisible)
        {
            _canvasGroup.alpha = isVisible ? 1 : 0;
        }
    }
}
