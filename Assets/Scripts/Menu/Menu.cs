using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button _prefabButton;
    [Space]
    [SerializeField] private LayoutGroup layoutGroup;

    public Button SpawnButton(Sprite logoButton)
    {
        Button button = Instantiate(_prefabButton);
        button.transform.SetParent(layoutGroup.transform);
        button.image.sprite = logoButton;

        return button;
    }
}
