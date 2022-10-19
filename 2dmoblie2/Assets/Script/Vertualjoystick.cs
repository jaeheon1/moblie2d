using UnityEngine;
using UnityEngine.EventSystems; //Ű���� , ���콺 , ��ġ�� �̺�Ʈ�� ������Ʈ�� �������ִ� ���ӽ����̽� �Դϴ�.
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
        //���� �������ϴ� ���� =���� ��Ź�� ��ġ -�ڽ��� ��ġ 
        var inputDirection = eventData.position - rectTransform.anchoredPosition;
        var clampDirection = inputDirection.magnitude < leverRange ? inputDirection : inputDirection.normalized * leverRange;

        lever.anchoredPosition = clampDirection;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //���� �������ϴ� ���� =���� ��Ź�� ��ġ -�ڽ��� ��ġ 
        var inputDirection = eventData.position - rectTransform.anchoredPosition;
        var clampDirection = inputDirection.magnitude < leverRange ? inputDirection : inputDirection.normalized * leverRange ;
        //(���� : inputDirection.magnitude<leverRange) 
        // ���̸� inputdirection
        // ���� inputDirection.normalized * leverRange
        lever.anchoredPosition = clampDirection;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //lever�� ��ġ�� x=0 y=0 ���� �ʱ�ȭ �մϴ�.
        lever.anchoredPosition = Vector2.zero;
    }
  
}
   