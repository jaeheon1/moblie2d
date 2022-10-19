using UnityEngine;
using UnityEngine.EventSystems; //키보드 , 마우스 , 터치를 이벤트로 오브젝트에 보낼수있는 네임스페이스 입니다.
public class Vertualjoystick : MonoBehaviour, IBeginDragHandler, IEndDragHandler,IDragHandler
{

    [SerializeField] RectTransform lever;
    private RectTransform rectTransform;

    [SerializeField,Range(10f,150f)]
    float leverRange;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //내가 가고자하는 방향 =현재 선탁한 위치 -자신의 위치 
        var inputDirection = eventData.position - rectTransform.anchoredPosition;
        var clampDirection = inputDirection.magnitude < leverRange ? inputDirection : inputDirection.normalized * leverRange;

        lever.anchoredPosition = clampDirection;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //내가 가고자하는 방향 =현재 선탁한 위치 -자신의 위치 
        var inputDirection = eventData.position - rectTransform.anchoredPosition;
        var clampDirection = inputDirection.magnitude < leverRange ? inputDirection : inputDirection.normalized * leverRange ;
        //(조건 : inputDirection.magnitude<leverRange) 
        // 참이면 inputdirection
        // 거짓 inputDirection.normalized * leverRange
        lever.anchoredPosition = clampDirection;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //lever의 위치를 x=0 y=0 으로 초기화 합니다.
        lever.anchoredPosition = Vector2.zero;
    }
  
}
   