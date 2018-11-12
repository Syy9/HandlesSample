using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Syy.Sample
{
    public class HandlesApiSample : EditorWindow
    {
        [MenuItem("Tools/HandlesApiSample")]
        public static void Open()
        {
            var window = GetWindow<HandlesApiSample>("Handles!");
            window.ResetSize();
        }

        void ResetSize()
        {
            var pos = position;
            pos.width = 300;
            pos.height = 300;
            position = pos;
        }

        void OnGUI()
        {
            if (GUILayout.Button("Reset", GUILayout.Width(100)))
            {
                ResetSize();
            }

            var rect = position;
            rect.x = rect.width - 100;
            rect.y = rect.height - EditorGUIUtility.singleLineHeight;
            EditorGUI.LabelField(rect, $"(W:{rect.width}, H={rect.height})");

            Handles.BeginGUI();

            // DrawAAConvexPolygon();
            // DrawAAPolyLine();
            // DrawBezier();
            // DrawDottedLine(); Does Nothing
            // DrawDottedLines(); Does Nothing
            // DrawLine();
            // DrawLines();
            // DrawPolyLine();

            Handles.EndGUI();
        }

        void DrawAAConvexPolygon(Color? color = null)
        {
            Handles.color = color ?? Color.red;

            var list = new List<Vector3>();
            list.Add(new Vector3(200, 50, 0));
            list.Add(new Vector3(140, 200, 0));
            list.Add(new Vector3(200, 220, 0));
            list.Add(new Vector3(40, 80, 0));
            Handles.DrawAAConvexPolygon(list.ToArray());
        }

        void DrawAAPolyLine(Color? color = null)
        {
            Handles.color = color ?? Color.red;

            var list = new List<Vector3>();
            list.Add(new Vector3(100, 100, 0));
            list.Add(new Vector3(100, 200, 0));
            list.Add(new Vector3(200, 200, 0));
            list.Add(new Vector3(200, 100, 0));
            Handles.DrawAAPolyLine(10, list.ToArray());
        }

        void DrawBezier(Color? color = null)
        {
            Handles.color = color ?? Color.red;

            var startPosition   = new Vector3(50, 150, 0);
            var endPosition     = new Vector3(250, 150, 0);
            var startTangent    = new Vector3(50, 250, 0);
            var endTangent      = new Vector3(250, 250, 0);
            Handles.DrawBezier(startPosition, endPosition, startTangent, endTangent, Color.red, null, 2);
        }

        /// <summary>
        /// HANDLES.DRAWDOTTEDLINE DOES NOTHING WHEN USED IN THE EDITOR
        /// https://issuetracker.unity3d.com/issues/handles-dot-drawdottedline-does-nothing-when-used-in-the-editor
        /// </summary>
        void DrawDottedLine(Color? color = null)
        {
            Handles.color = color ?? Color.red;

            var startPosition = new Vector3(50, 150, 0);
            var endPosition = new Vector3(250, 150, 0);
            Handles.DrawDottedLine(startPosition, endPosition, 1);
        }

        /// <summary>
        /// HANDLES.DRAWDOTTEDLINE DOES NOTHING WHEN USED IN THE EDITOR
        /// https://issuetracker.unity3d.com/issues/handles-dot-drawdottedline-does-nothing-when-used-in-the-editor
        /// </summary>
        void DrawDottedLines(Color? color = null)
        {
            Handles.color = color ?? Color.red;

            var startPosition = new Vector3(50, 150, 0);
            var endPosition = new Vector3(250, 150, 0);
            Handles.DrawDottedLines(new Vector3[] { startPosition, endPosition }, 2);
        }

        void DrawLine(Color? color = null)
        {
            Handles.color = color ?? Color.red;

            var p1 = new Vector3(50, 150, 0);
            var p2 = new Vector3(250, 150, 0);
            Handles.DrawLine(p1, p2);
        }

        void DrawLines(Color? color = null)
        {
            Handles.color = color ?? Color.red;

            var p1_1 = new Vector3(50, 100, 0);
            var p1_2 = new Vector3(250, 100, 0);
            var p2_1 = new Vector3(50, 150, 0);
            var p2_2 = new Vector3(250, 150, 0);
            var p3_1 = new Vector3(50, 200, 0);
            var p3_2 = new Vector3(250, 200, 0);
            var p4_1 = new Vector3(50, 250, 0);
            var p4_2 = new Vector3(250, 250, 0);
            var points = new Vector3[] { p1_1, p1_2, p2_1, p2_2, p3_1, p3_2, p4_1, p4_2 };
            Handles.DrawLines(points);
        }

        void DrawPolyLine(Color? color = null)
        {
            Handles.color = color ?? Color.red;

            var p1_1 = new Vector3(50, 100, 0);
            var p1_2 = new Vector3(250, 100, 0);
            var p2_1 = new Vector3(50, 150, 0);
            var p2_2 = new Vector3(250, 150, 0);
            var p3_1 = new Vector3(50, 200, 0);
            var p3_2 = new Vector3(250, 200, 0);
            var p4_1 = new Vector3(50, 250, 0);
            var p4_2 = new Vector3(250, 250, 0);
            var points = new Vector3[] { p1_1, p1_2, p2_1, p2_2, p3_1, p3_2, p4_1, p4_2 };
            Handles.DrawPolyLine(points);
        }
    }
}
