using UnityEngine;
using DG.Tweening;

public class CubeAnimations : MonoBehaviour
{
    // ��������� ��� ���������
    public float rotationDuration = 1f;
    public Ease rotationEase = Ease.InOutQuad;

    // ��������� ��� ��������
    public Vector3 scaleAmount = new Vector3(1.2f, 1.2f, 1.2f);
    public float scaleDuration = 0.5f;
    public Ease scaleEase = Ease.OutBack;

    void Update()
    {
        // �������� ���������� ������ 1 ��� ��������� ����
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("<color=blue>Button 1 pressed</color>. The cube will rotate.");
            transform.DORotate(new Vector3(0, 360, 0), rotationDuration, RotateMode.FastBeyond360)
                     .SetEase(rotationEase);
        }

        // �������� ���������� ������ 2 ��� ���� �������� ����
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("<color=green>Button 2 pressed</color>. The cube will scale.");
            transform.DOPunchScale(scaleAmount, scaleDuration, 1, 0)
                     .SetEase(scaleEase);
        }
    }
}
