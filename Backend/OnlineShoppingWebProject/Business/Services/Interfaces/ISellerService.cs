﻿using Business.Dto.Article;
using Business.Dto.Auth;
using Business.Result;

namespace Business.Services
{
	public interface ISellerService
	{
		IServiceOperationResult AddArticle(NewArticleDto articleDto, JwtDto jwtDto);

		IServiceOperationResult UpdateArticle(ArticleUpdateDto articleDto, JwtDto jwtDto);

		IServiceOperationResult GetAllArticles(JwtDto jwtDto);

		IServiceOperationResult GetArticleDetails(JwtDto jwtDto, string name);

		IServiceOperationResult UpdateArticleProductImage(ArticleProductImageUpdateDto articleDto, JwtDto jwtDto);

		IServiceOperationResult DeleteArticle(string articleName, JwtDto jwtDto);

		IServiceOperationResult GetPendingOrders(JwtDto jwtDto);

		IServiceOperationResult GetFinishedOrders(JwtDto jwtDto);

		IServiceOperationResult GetOrderDetails(JwtDto jwtDto, long id);
	}
}
