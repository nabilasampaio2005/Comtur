﻿using Jose;
using Microsoft.AspNetCore.Mvc;
using COMTUR.Repositorios.Interfaces;
using System.Text;
using Newtonsoft.Json;
using COMTUR.Models;

namespace COMTUR.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : Controller
	{
		private readonly IUsuarioRepositorio _usuarioRepositorio;

		public LoginController(IUsuarioRepositorio usuarioRepositorio)
		{
			_usuarioRepositorio = usuarioRepositorio;
		}
		/*
		[HttpPost("ValidarLogin")]
		public async Task<ActionResult> ValidarLogin([FromBody] LoginModel loginModel)
		{
			if (loginModel is null) return BadRequest("Dado inválido!");
			var UsuarioModel = await _usuarioRepositorio.Autenticacao(loginModel);

			if (!(UsuarioModel is null))
			{
				if (loginModel.Email == UsuarioModel.EmailUsuario && loginModel.Senha == UsuarioModel.SenhaUsuario)
				{
					if (UsuarioModel.StatusUsuario)
					{
						EntitySecurity entitySecurity = new EntitySecurity();
						var token = GenerateToken(entitySecurity.Key, entitySecurity.Issuer, entitySecurity.Audience, UsuarioModel.EmailUsuario, 1);
						return Ok(new { token, usuario = UsuarioModel });
					}
					else
					{
						return Unauthorized(new { message = "O usuário " + UsuarioModel.Nome + " está inativo!" });
					}
				}
			}

			return Unauthorized(new { message = "E-mail ou senha incorretos!" });
		}

		private static string GenerateToken(string secretKey, string issuer, string audience, string subject, int expiryInMinutes)
		{
			var payload = new Dictionary<string, object>
			{
				{ "iss", issuer },
				{ "aud", audience },
				{ "sub", subject },
				{ "exp", DateTimeOffset.UtcNow.AddHours(expiryInMinutes).ToUnixTimeSeconds() }
			};

			string token = JWT.Encode(payload, Encoding.UTF8.GetBytes(secretKey), JwsAlgorithm.HS256);
			return token;
		}

		[HttpPost("Validation")]
		public ActionResult Validation([FromBody] ValidacaoModel ValidacaoModel)
		{
			if (ValidacaoModel is null) return BadRequest(new { validation = "false", message = "Dado inválido!" });

			EntitySecurity entitySecurity = new EntitySecurity();
			if (ValidateToken(ValidacaoModel.Token, entitySecurity.Issuer, entitySecurity.Audience, ValidacaoModel.Email))
			{
				return Ok(new { validation = "true" });
			}
			else
			{
				return Unauthorized(new { validation = "false", message = "Acesso negado!" });
			}
		}

		private static bool ValidateToken(string token, string issuer, string audience, string expectedEmail)
		{
			// Passo 1: Verificar se o token tem três partes
			string[] tokenParts = token.Split('.');
			if (tokenParts.Length != 3)
			{
				return false;
			}

			try
			{
				// Passo 2: Decodificar o token
				string decodedToken = Encoding.UTF8.GetString(Base64Url.Decode(tokenParts[1]));

				// Passo 3: Verificar iss, aud e sub
				var payload = JsonConvert.DeserializeObject<Dictionary<string, object>>(decodedToken);
				if (!payload.TryGetValue("iss", out object issuerClaim) ||
					!payload.TryGetValue("aud", out object audienceClaim) ||
					!payload.TryGetValue("sub", out object subjectClaim))
				{
					return false;
				}

				if (issuerClaim.ToString() != issuer || audienceClaim.ToString() != audience || subjectClaim.ToString() != expectedEmail)
				{
					return false;

					// Passo 5: Se tudo estiver certo
					return true;
				}


			catch (Exception)
			{
				return false;
			}
		} */
	}
}