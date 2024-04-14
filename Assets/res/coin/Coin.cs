using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 10f; // 旋转的速度

    void Update()
    {
        // 根据旋转速度和时间来计算旋转角度
        float rotationAngle = rotationSpeed * Time.deltaTime;

        // 使用Quaternion.Euler创建旋转的四元数
        Quaternion rotation = Quaternion.Euler(0, rotationAngle, 0);

        // 将旋转应用于物体的变换
        transform.rotation *= rotation;
    }
}