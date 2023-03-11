using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using System;
using Probeaufgabe_AutoCad;
using System.Reflection;
using Spire.Pdf.Exporting.XPS.Schema;

[assembly: CommandClass(typeof(Probeaufgabe_AutoCad.MyCommands))]

namespace Probeaufgabe_AutoCad
{
    public class MyCommands
    {
        [CommandMethod("GetAttribute", CommandFlags.UsePickSet)]

        public void getAttributes()
        {
            Document attrbDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database attrbDaba = attrbDoc.Database;

            Editor attrbEd = attrbDoc.Editor;

            


            attrbEd.WriteMessage("Select a block and continue with Enter/Space.");

            using (Transaction attribTrans = attrbDaba.TransactionManager.StartTransaction())
            {
                PromptSelectionResult selectRes = attrbDoc.Editor.GetSelection();
                string tag = null;
                string prompt = null;
                
                if (selectRes.Status  == PromptStatus.OK) 
                {
                    SelectionSet selectSet = selectRes.Value;

                    ObjectId[] idArray = selectSet.GetObjectIds();

                    foreach (ObjectId blockID in idArray)
                    {
                        BlockReference blockRef = (BlockReference)attribTrans.GetObject(blockID, OpenMode.ForRead);

                        BlockTableRecord blockRec =  (BlockTableRecord)attribTrans.GetObject(blockRef.BlockTableRecord, OpenMode.ForRead);

                        attrbEd.WriteMessage("\nBlock: " + blockRec.Name);

                        blockRec.Dispose();

                        AttributeCollection attrbColl = blockRef.AttributeCollection;

                        foreach (ObjectId attrbId in attrbColl)
                        {
                            AttributeReference attrbRef = (AttributeReference)attribTrans.GetObject(attrbId, OpenMode.ForRead);

                             tag = ("" + attrbRef.Tag);
                             prompt = ("" + attrbRef.TextString);              

                        }
                    }
                    MessageModal attributeExport = new MessageModal(tag, prompt);

                    Application.ShowModalDialog(null, attributeExport, false);
                    attribTrans.Commit();
                }
            }
        }
    }
}
