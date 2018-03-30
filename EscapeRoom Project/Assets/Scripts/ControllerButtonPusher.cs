using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerButtonPusher : MonoBehaviour {

    private ArrayList code;
	private ArrayList rightCode;
	public AudioSource hit;
	public AudioSource wrong;
	public AudioSource right;
    public bool open;
    public Text CodeNum;

	private Rigidbody rb;


    private void setText(int num)
    {
        CodeNum.text += num + " ";
    }



	void Start ()
	{
        rightCode = new ArrayList();
        rightCode.Add(1);
        rightCode.Add(2);
        rightCode.Add(3);
        rightCode.Add(4);
        code = new ArrayList();
        CodeNum.text = "Code: ";
    }

	void FixedUpdate ()
	{
		
	}

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Zero"))
        {
            code.Add(0);
            hit.Play();
            setText(0);
        }
		else if (other.gameObject.CompareTag("One"))
        {
            code.Add(1);
            hit.Play();
            setText(1);
        }
		else if (other.gameObject.CompareTag("Two"))
        {
            code.Add(2);
            hit.Play();
            setText(2);
        }
		else if (other.gameObject.CompareTag("Three"))
        {
            code.Add(3);
            hit.Play();
            setText(3);
        }
		else if (other.gameObject.CompareTag("Four"))
        {
            code.Add(4);
            hit.Play();
            setText(4);
        }
		else if (other.gameObject.CompareTag("Five"))
        {
            code.Add(5);
            hit.Play();
            setText(5);
        }
		else if (other.gameObject.CompareTag("Six"))
        {
            code.Add(6);
            hit.Play();
            setText(6);
        }
		else if (other.gameObject.CompareTag("Seven"))
        {
            code.Add(7);
            hit.Play();
            setText(7);
        }
		else if (other.gameObject.CompareTag("Eight"))
        {
            code.Add(8);
            hit.Play();
            setText(8);
        }
		else if (other.gameObject.CompareTag("Nine"))
        {
            code.Add(9);
            hit.Play();
            setText(9);
        }
		else if (other.gameObject.CompareTag("Green"))
		{
            if(code.Count == rightCode.Count)
            {
                for(int i = 0; i < rightCode.Count; i++)
                {
                    if(code[i] != rightCode[i])
                    {
                        wrong.Play();
                        code = new ArrayList();
                        CodeNum.text = "Code: ";
                        break;
                    }
                    if (i == rightCode.Count - 1)
                    {
                        right.Play();
                        CodeNum.text += "right";
                        open = true;
                    }
                }
            }
			else
			{
				wrong.Play();
				code = new ArrayList();
                CodeNum.text = "Code: ";
			}
		}
		else if (other.gameObject.CompareTag("Red"))
		{
			wrong.Play();
			code = new ArrayList();
            CodeNum.text = "Code: ";
		}




        //System.Threading.Thread.Sleep(2000);
    }
}
