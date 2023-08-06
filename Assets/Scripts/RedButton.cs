using UnityEngine;
using UnityEngine.EventSystems;

public class RedButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Eventer.MyButton(gameObject.tag);
    }
}
