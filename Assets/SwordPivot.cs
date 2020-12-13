﻿using UnityEngine;

public class SwordPivot : MonoBehaviour
{
    private void FixedUpdate()
    {
        SpinSword();
    }

    void SpinSword()
    {
        Vector2 diffrence = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        diffrence.Normalize();

        float rotationZ = Mathf.Atan2(diffrence.y, diffrence.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
    }
}
