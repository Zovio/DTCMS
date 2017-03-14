using System;
using System.Data;
using System.Collections.Generic;

namespace DTcms.Web.Plugin.Advert.BLL
{
    /// <summary>
    /// ���Banner
    /// </summary>
    public partial class advert_banner
    {
        private readonly DTcms.Model.siteconfig siteConfig = new DTcms.BLL.siteconfig().loadConfig(); //���վ��������Ϣ
        private readonly DAL.advert_banner dal;

        public advert_banner()
        {
            dal = new DAL.advert_banner(siteConfig.sysdatabaseprefix);
        }

        #region ��ID�Ų�ѯ�Ƿ���ڼ�¼
        /// <summary>
        /// ��ID�Ų�ѯ�Ƿ���ڼ�¼
        /// </summary>
        /// <param name="id">ID��</param>
        /// <returns></returns>
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }
        #endregion


        #region �����Ʋ�ѯ�Ƿ���ڼ�¼
        /// <summary>
        /// �����Ʋ�ѯ�Ƿ���ڼ�¼
        /// </summary>
        /// <param name="title">����</param>
        /// <returns></returns>
        public bool Exists(string title)
        {
            return dal.Exists(title);
        }
        #endregion

        #region ��ID�Ų�ѯ����
        /// <summary>
        /// ��ID�Ų�ѯ����
        /// </summary>
        /// <param name="id">ID��</param>
        public string GetTitle(int id)
        {
            return dal.GetTitle(id);
        }
        #endregion

        #region ����һ������
        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Model.advert_banner model)
        {
            return dal.Add(model);
        }
        #endregion

        #region �޸�һ������
        /// <summary>
        /// �޸�һ������
        /// </summary>
        public void UpdateField(int id, string strValue)
        {
            dal.UpdateField(id, strValue);
        }
        #endregion

        #region ����һ������
        /// <summary>
        /// ����һ������
        /// </summary>
        public bool Update(Model.advert_banner model)
        {
            return dal.Update(model);
        }
        #endregion

        #region ɾ��һ������
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public bool Delete(int id)
        {
            return dal.Delete(id);
        }
        #endregion

        #region ��������ѯ��������
        /// <summary>
        /// ��������ѯ��������
        /// </summary>
        /// <param name="strWhere">����</param>
        public int GetCount(string strWhere)
        {
            return dal.GetCount(strWhere);
        }
        #endregion

        #region ����һ��ʵ��
        /// <summary>
        /// ����һ��ʵ��
        /// </summary>
        /// <returns>Modle</returns>
        public Model.advert_banner GetModel(int id)
        {
            return dal.GetModel(id);
        }
        #endregion

        #region ���ǰ��������
        /// <summary>
        /// ���ǰ��������
        /// </summary>
        /// <param name="Top">����</param>
        /// <param name="strWhere">����</param>
        /// <param name="filedOrder">����</param>
        /// <returns>DataTable</returns>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        #endregion

        #region ��ȡ��ҳ�б�
        /// <summary>
        /// ��ȡ��ҳ�б�
        /// </summary>
        /// <param name="strWhere">����</param>
        /// <param name="filedOrder">����</param>
        /// <param name="page">ҳ��</param>
        /// <param name="pagesize">��ҳ��</param>
        /// <param name="recordCount">���� ��������</param>
        /// <returns>DataTable</returns>
        public DataSet GetList(string strWhere, string filedOrder, int pageIndex, int pageSize, out int recordCount)
        {
            return dal.GetList(strWhere, filedOrder, pageIndex, pageSize, out recordCount);
        }
        #endregion
    }
}