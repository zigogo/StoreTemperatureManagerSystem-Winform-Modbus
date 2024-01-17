
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STML.Models.DModels;
using STMS.BLL;
using STMS.Models;

namespace STMS.store
{
    public static class FormUtility
    {
        #region AddPanelForm():将指定的From显示到当前Panel中
        /// <summary>
        /// 将指定的From显示到当前Panel中
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="form"></param>
        public static void AddPanelForm(this Panel panel, Form form)
        {
            //检查Form是否已经打开
            if (CheckOpenForm(form.Name))
            {//已经打开
                Form f = GetOpenForm(form.Name);
                bool IsShowPanel = false;//指示是否已经显示在Panel
                foreach (Control control in panel.Controls)
                {
                    if (control is Form)
                    {
                        Form formInPanel = control as Form;
                        if (formInPanel.Name == f.Name)
                        {
                            form = formInPanel;
                            IsShowPanel = true;
                            break;
                        }
                    }
                }
                if (!IsShowPanel)
                {//没有显示在Panel里
                    form = f;
                }
            }
            panel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            panel.AutoScroll = true;
            panel.Controls.Add(form);
            form.Show();
        }

        /// <summary>
        /// 根据Name获取Form
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="NotImplementedException"></exception>
        private static Form GetOpenForm(string formName)
        {
            Form form = null;
            foreach (Form formOpen in Application.OpenForms)
            {
                if (formOpen.Name == formName)
                {
                    form = formOpen;
                    break;
                }
            }
            return form;
        }


        /// <summary>
        /// 根据Form的Name判断该Form是否已经打开
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private static bool CheckOpenForm(string formName)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                {
                    return true;//已打开
                }
            }
            return false;//没打开
        }
        #endregion

        /// <summary>
        /// dataGridView对修改、删除、移除、恢复 操作列显示的改变
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="isDelete"></param>
        public static void dGVShowContent(this DataGridView dataGridView, bool isDelete)
        {
            dataGridView.Columns["ColumnEdit"].Visible = !isDelete;//修改
            dataGridView.Columns["ColumnDelete"].Visible = !isDelete;//删除
            dataGridView.Columns["ColumnRemove"].Visible = isDelete;//移除
            dataGridView.Columns["ColumnRecover"].Visible = isDelete;//恢复
        }

        /// <summary>
        /// 根据delType获取期望执行的操作的名称--删除、移除、恢复
        /// 对应关系：0--删除   1--移除   2--恢复
        /// </summary>
        /// <param name="delType"></param>
        public static string GetDelName(int delType)
        {
            switch (delType)
            {
                case 0:
                    return "删除";
                case 1:
                    return "移除";
                case 2:
                    return "恢复";
            }
            return "";
        }
        /// <summary>
        /// 给comboBox加上仓库数据（搜索框的仓库信息）
        /// </summary>
        /// <param name="comboBox"></param>
        public static void LoadComboBoxStoresSearch(ComboBox comboBox)
        {
            StoreInfoBLL storeInfosBLL = new StoreInfoBLL();
            List<StoreInfo> storeInfos = storeInfosBLL.GetAllStore();
            //插入第一个元素提醒信息
            storeInfos.Insert(0, new StoreInfo()
            {
                StoreId = 0,
                StoreName = "全部"
            }) ;
            //显示的
            comboBox.DisplayMember = "StoreName";
            //数据
            comboBox.ValueMember = "StoreId";
            comboBox.DataSource = storeInfos;
            comboBox.SelectedIndex = 0;//默认显示的元素
        }
        /// <summary>
        /// 给comboBox加上仓库数据（新增仓库分区页面的仓库信息）
        /// </summary>
        /// <param name="comboBox"></param>
        public static void LoadComboBoxStoresNew(ComboBox comboBox)
        {
            StoreInfoBLL storeInfosBLL = new StoreInfoBLL();
            List<StoreInfo> storeInfos = storeInfosBLL.GetAllStore();
            //插入第一个元素提醒信息
            storeInfos.Insert(0, new StoreInfo()
            {
                StoreId = 0,
                StoreName = "仓库名称"
            });
            //显示的
            comboBox.DisplayMember = "StoreName";
            //数据
            comboBox.ValueMember = "StoreId";
            comboBox.DataSource = storeInfos;
            comboBox.SelectedIndex = 0;//默认显示的元素
        }
        public static void LoadComboBoxStates(ComboBox comboBox)
        {
            //显示的
            comboBox.DisplayMember = "StateText";
            //数据
            comboBox.ValueMember = "TemperState";
            comboBox.DataSource= GetRegionStateInfoList();
            comboBox.SelectedIndex = 0;


        }
        public static List<RegionStateInfo> GetRegionStateInfoList()
        {
            List<RegionStateInfo> regionStateInfos = new List<RegionStateInfo>()
            {
                new RegionStateInfo() {TemperState=-1,StateText="全部"},
                new RegionStateInfo() {TemperState=0,StateText="低温"},
                new RegionStateInfo() {TemperState=1,StateText="正常"},
                new RegionStateInfo() {TemperState=2,StateText="高温"},
            };
            return regionStateInfos;
        }
    }
}
