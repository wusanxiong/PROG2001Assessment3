using System.Collections.Generic;
using UnityEngine;

namespace Supercyan.FreeSample
{
    public class FreeCameraLogic : MonoBehaviour
    {

        public Transform targetPlayer;
        public Vector3 offset = new Vector3(0, 2, -3); // 自定义的位置偏移
        private float distance = 3.0f; // 相机到玩家的距离
        private float rotationSpeed = 2.0f; // 旋转速度
        private bool isRightMouseButtonDown = false;

        void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                isRightMouseButtonDown = true;
            }

            if (Input.GetMouseButtonUp(1))
            {
                isRightMouseButtonDown = false;
            }

            if (isRightMouseButtonDown)
            {
                HandleRotationAroundPlayer();
            }
            else
            {
                FollowPlayer();
            }
        }

        void HandleRotationAroundPlayer()
        {
            float horizontalInput = Input.GetAxis("Mouse X") * rotationSpeed;
            targetPlayer.Rotate(Vector3.up, horizontalInput);
            Vector3 direction = targetPlayer.position - transform.position;
            Quaternion rotation = Quaternion.AngleAxis(horizontalInput, Vector3.up);
            direction = rotation * direction;
            transform.position = targetPlayer.position - direction.normalized * distance;
            transform.LookAt(targetPlayer);
        }

        void FollowPlayer()
        {
            Vector3 targetPosition = targetPlayer.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
        }
    }
}
