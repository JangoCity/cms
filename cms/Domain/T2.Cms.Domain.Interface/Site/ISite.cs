﻿
/*
* Copyright(C) 2010-2013 TO2.NET
* 
* File Name	: Site.cs
* author_id	: Newmin (new.min@msn.com)
* Create	: 2013/05/21 19:59:54
* Description	:
*
*/

using System;
using System.Collections.Generic;
using System.Text;
using T2.Cms.Domain.Interface.Common.Language;
using T2.Cms.Domain.Interface.Site.Category;
using T2.Cms.Domain.Interface.Site.Extend;
using T2.Cms.Domain.Interface.Site.Link;
using T2.Cms.Domain.Interface.User;
using T2.Cms.Infrastructure;
using T2.Cms.Infrastructure.Tree;
using T2.Cms.Models;

namespace T2.Cms.Domain.Interface.Site
{
    /// <summary>
    /// 站点
    /// </summary>
    public interface ISite:IAggregateroot
    {
        /// <summary>
        /// 获取值
        /// </summary>
        /// <returns></returns>
        CmsSiteEntity Get();

        /// <summary>
        /// 设置值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        Error Set(CmsSiteEntity value);

        /// <summary>
        /// 获取基础URL,如:http://to2.net/cms/.
        /// 如果未绑定域名，则用#代替Host部分,如：
        /// http://#/sub
        /// </summary>
        string FullDomain { get;}

        /// <summary>
        /// 是否为虚拟目录
        /// </summary>
        SiteRunType RunType();

        /// <summary>
        /// 站点使用语言
        /// </summary>
        Languages Language();

        /// <summary>
        /// 站点状态
        /// </summary>
        SiteState State();


        /// <summary>
        /// 保存站点并返回编号
        /// </summary>
        int Save();

        /// <summary>
        /// 扩展管理器
        /// </summary>
        IExtendManager GetExtendManager();

        /// <summary>
        /// 链接管理器
        /// </summary>
        ISiteLinkManager GetLinkManager();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IAppUserManager GetUserManager();

        /// <summary>
        /// 分类
        /// </summary>
        IList<ICategory> Categories { get; }

        /// <summary>
        /// 分类根节点
        /// </summary>
        ICategory RootCategory { get; }


        ICategory GetCategory(int categoryId);


        /// <summary>
        /// 根据栏目路径获取站点下的分类
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        ICategory GetCategoryByPath(string path);

        /// <summary>
        /// 根据栏目名称获取栏目
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        ICategory GetCategoryByName(string categoryName);

        IEnumerable<ICategory> GetCategories(int catId, CategoryContainerOption option);

        ICategory GetCategoryByLft(int lft);

        bool DeleteCategory(int lft);

        /// <summary>
        /// 迭代栏目树
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="catId"></param>
        void ItreCategoryTree(StringBuilder sb, int catId);

        /// <summary>
        /// 处理分类树
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="treeHandler"></param>
        void HandleCategoryTree(int parentId, CategoryTreeHandler treeHandler);

        /// <summary>
        /// 获取栏目树
        /// </summary>
        /// <returns></returns>
        TreeNode GetCategoryTree(int lft);

        /// <summary>
        /// 获取栏目树，包含根节点
        /// </summary>
        /// <returns></returns>
        TreeNode GetCategoryTreeWithRootNode();

        /// <summary>
        /// 重新加载数据
        /// </summary>
        void ClearSelf();
        void SetRunType(SiteRunType stand);
    }
}
