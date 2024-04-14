using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 10f; // ��ת���ٶ�

    void Update()
    {
        // ������ת�ٶȺ�ʱ����������ת�Ƕ�
        float rotationAngle = rotationSpeed * Time.deltaTime;

        // ʹ��Quaternion.Euler������ת����Ԫ��
        Quaternion rotation = Quaternion.Euler(0, rotationAngle, 0);

        // ����תӦ��������ı任
        transform.rotation *= rotation;
    }
}