using UnityEngine;

//unnecessary to inerhit form monoBehaviour

//check colliding with some kind of layer

  public bool IsGrounded(GameObject go, LayerMask layer)
    {
        Collider2D _col = go.GetComponent<Collider2D>();

        if(_col.IsTouchingLayers(layer))
        {
            return true;
        } else
        {
            return false;
        }
    }
