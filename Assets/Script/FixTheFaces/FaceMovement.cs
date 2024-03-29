using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tapas
{
    public class FaceMovement : MonoBehaviour
    {
        public GameObject rightPlace;
        private bool moving;
        private bool finish;
        private float startPosX;
        private float startPosY;
        private Vector3 resetPosition;

        void Start()
        {
            resetPosition = this.transform.localPosition;
        }

        void Update()
        {
            if (finish == false)
            {
                if(moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            }
            }
        }
        private void OnMouseDown() {
            if(Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                startPosX = mousePos.x - this.transform.localPosition.x;
                startPosY = mousePos.y - this.transform.localPosition.y;
                moving = true;
            }
        }
        private void OnMouseUp() {
            moving = false;
            if(Mathf.Abs(this.transform.localPosition.x - rightPlace.transform.localPosition.x) <= 0.5f &&
               Mathf.Abs(this.transform.localPosition.y - rightPlace.transform.localPosition.y) <= 0.5f)
            {
                this.transform.position = new Vector3(rightPlace.transform.position.x, rightPlace.transform.position.y, rightPlace.transform.position.z);
                finish = true;
            }
            else
            {
                this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
            }
        }
    }
}
