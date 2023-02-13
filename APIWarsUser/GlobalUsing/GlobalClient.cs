/*
 * Глобальные обработчики (API Wars)
*/
global using APIWarsUser.ActionClass;
global using APIWarsUser.ActionClass.HelperClass;
global using APIWarsUser.Controllers;
global using APIWarsUser.ActionClass.HelperClass.ExtraModels;
global using APIWarsUser.ActionClass.HelperClass.Account;
global using APIWarsUser.Models;
global using APIWarsUser.Interface;
global using APIWarsUser.ActionClass.HelperClass.Drone;

/*
 * Глобальные обработчики (Microsoft)
*/
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.IdentityModel.Tokens;
global using DotNet.RateLimiter;
global using DotNet.RateLimiter.ActionFilters;
global using Newtonsoft.Json;

/*
 * Глобальные обработчики (Системные)
 */
global using System.IdentityModel.Tokens.Jwt;
global using System.Security.Claims;
global using System.Text;
