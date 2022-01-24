using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boksCollider : MonoBehaviour
{
    public float widthFillRatio = 1;
    public float heightFillRatio = 1;

    // Use this for initialization
    void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();

        if (rectTransform == null)
        {
            return;
        }

        float width = rectTransform.rect.size.x;
        float height = rectTransform.rect.size.y;

        BoxCollider2D[] colliders2D = GetComponents<BoxCollider2D>();
        foreach (BoxCollider2D c in colliders2D)
        {
            c.size = new Vector2(width * widthFillRatio, height * heightFillRatio);
        }
    }
}
