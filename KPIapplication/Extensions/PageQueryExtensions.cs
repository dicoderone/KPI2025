﻿using KPIapplication.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace KPIapplication.Extensions
{
    public static class PageQueryExtensions
    {
        private static int maxPageSize = 100;
        private static string paginationKey = "X-Pagination";

        public static IQueryable<T> ToPagedList<T>(
        this IQueryable<T> source,
        HttpContext httpContext,
        int pageSize,
        int pageIndex)
        {
            if (pageSize <= 0 || pageIndex <= 0)
            {
                throw new ValidationException(
                    "Page size or index should be greater than 0");
            }

            if (pageSize > maxPageSize)
            {
                throw new ValidationException(
                    $"Page size should be less than {maxPageSize}");
            }

            var paginationMetadata = new PaginationMetaData(
                totalCount: source.Count(),
                currentPage: pageIndex,
                pageSize: pageSize);

            httpContext.Response.Headers[paginationKey] = JsonSerializer
                .Serialize(paginationMetadata);

            return source
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize);
        }
    }
}
