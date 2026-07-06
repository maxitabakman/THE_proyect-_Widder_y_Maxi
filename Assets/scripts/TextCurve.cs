using UnityEngine;
using TMPro;

[ExecuteAlways]
[RequireComponent(typeof(TMP_Text))]
public class TextCurve : MonoBehaviour
{
    [Range(-50f, 50f)]
    public float curveAmount = 10f;

    private TMP_Text text;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    void LateUpdate()
    {
        if (text == null)
            text = GetComponent<TMP_Text>();

        text.ForceMeshUpdate();

        TMP_TextInfo textInfo = text.textInfo;

        for (int i = 0; i < textInfo.characterCount; i++)
        {
            if (!textInfo.characterInfo[i].isVisible)
                continue;

            int materialIndex = textInfo.characterInfo[i].materialReferenceIndex;
            int vertexIndex = textInfo.characterInfo[i].vertexIndex;

            Vector3[] vertices = textInfo.meshInfo[materialIndex].vertices;

            Vector3 mid = (vertices[vertexIndex] + vertices[vertexIndex + 2]) / 2f;

            float x = mid.x / text.bounds.size.x;
            float y = -(x * x) * curveAmount + curveAmount / 4f;

            for (int j = 0; j < 4; j++)
            {
                vertices[vertexIndex + j] += new Vector3(0, y, 0);
            }
        }

        for (int i = 0; i < textInfo.meshInfo.Length; i++)
        {
            textInfo.meshInfo[i].mesh.vertices = textInfo.meshInfo[i].vertices;
            text.UpdateGeometry(textInfo.meshInfo[i].mesh, i);
        }
    }
}