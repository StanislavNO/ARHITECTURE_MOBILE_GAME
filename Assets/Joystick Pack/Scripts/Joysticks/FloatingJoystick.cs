using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FloatingJoystick : Joystick
{
    //[SerializeField] private Button _fire;

    //private bool _isFifeButtonUp = false;

    //private void Awake()
    //{
    //    _fire.onClick.AddListener(GetButtonUpFire);
    //    _fire.OnPointerUp += ;
    //}

    //private void GetButtonUpFire()
    //{

    //}

    protected override void Start()
    {
        base.Start();
        background.gameObject.SetActive(false);
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        background.anchoredPosition = ScreenPointToAnchoredPosition(eventData.position);
        background.gameObject.SetActive(true);
        base.OnPointerDown(eventData);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        background.gameObject.SetActive(false);
        base.OnPointerUp(eventData);
    }
}