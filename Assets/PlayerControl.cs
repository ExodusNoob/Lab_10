using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Transform _compTransform;
    private SpriteRenderer _compSpriteRenderer;
    public float speed;
    public int xDirection;
    public int yDirection;

    // Start is called before the first frame update
    void Awake()
    {
        _compTransform = GetComponent<Transform>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        speed = 5;
        xDirection = 1;
        yDirection = 1;
    }

    // Update is called once per frame
    void Update()
    {
        _compTransform.position = new Vector2(_compTransform.position.x + speed * xDirection * Time.deltaTime, _compTransform.position.y + speed * yDirection * Time.deltaTime);
        if (_compTransform.position.x >= 4.9)
        {
            xDirection = -1;
            _compSpriteRenderer.flipX = true;
        }
        if (_compTransform.position.x <= -4.9)
        {
            _compSpriteRenderer.flipX = false;
            xDirection = 1;
        }
        if (_compTransform.position.y >= 4)
        {
            yDirection = -1;
            _compSpriteRenderer.flipY = true;
        }
        if (_compTransform.position.y <= -4)
        {
            yDirection = 1;
            _compSpriteRenderer.flipY = false;
        }

    }
}
