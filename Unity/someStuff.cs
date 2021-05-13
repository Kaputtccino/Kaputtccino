using UnityEngine;

//unnecessary to inherit form monoBehaviour

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

//enemy line of sight
    public void PlayerInSight(GameObject own, GameObject target)
    {
        RaycastHit2D hit = Physics2D.Linecast(own.transform.position, Vector2.MoveTowards(own.transform.position, target.transform.position, 5f));

        Debug.DrawLine(own.transform.position, Vector2.MoveTowards(own.transform.position, target.transform.position, 5f), Color.blue);

        if (hit.collider != null && hit.collider.gameObject.tag == "Player")
        {
            Debug.Log("got you");
        }
    }
