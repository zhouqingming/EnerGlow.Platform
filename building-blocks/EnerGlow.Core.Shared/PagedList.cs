using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 分页对象
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedList<T>
    {
        /// <summary>
        /// 无参构造
        /// 用于反序列化
        /// </summary>
        public PagedList()
        {

        }

        /// <summary>
        /// 有参构造
        /// </summary>
        /// <param name="data">全部数据</param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        public PagedList(List<T> data, int pageIndex, int pageSize)
        {
            PageData = data != null && data.Count > 0 ? data.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList() : new List<T>();
            PageSize = pageSize;
            TotalItemCount = data == null ? 0 : data.Count;
            TotalPageCount = (int)Math.Ceiling(TotalItemCount / (double)PageSize);
            CurrentPageIndex = pageIndex;
            StartRecordIndex = TotalItemCount == 0 ? 0 : (pageIndex - 1) * PageSize + 1;
            EndRecordIndex = TotalItemCount > pageIndex * pageSize ? pageIndex * pageSize : TotalItemCount;
        }

        /// <summary>
        /// 有参构造
        /// </summary>
        /// <param name="items">分页数据</param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalItemCount"></param>
        public PagedList(List<T> items, int pageIndex, int pageSize, long totalItemCount)
        {
            PageData = items != null && items.Count > 0 ? items : new List<T>();
            TotalItemCount = totalItemCount;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)pageSize);
            CurrentPageIndex = pageIndex;
            PageSize = pageSize;
            StartRecordIndex = TotalItemCount == 0 ? 0 : (pageIndex - 1) * pageSize + 1;
            EndRecordIndex = TotalItemCount > pageIndex * pageSize ? pageIndex * pageSize : totalItemCount;
        }

        #region 属性

        /// <summary>
        /// 页数据
        /// </summary>
        public List<T> PageData { get; set; }

        /// <summary>
        /// 当前页索引
        /// </summary>
        public int CurrentPageIndex { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        public long TotalItemCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public long TotalPageCount { get; set; }

        /// <summary>
        /// 记录起始索引
        /// </summary>
        public long StartRecordIndex { get; set; }

        /// <summary>
        /// 记录结束索引
        /// </summary>
        public long EndRecordIndex { get; set; }

        #endregion
    }
}
