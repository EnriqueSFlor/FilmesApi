﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateFilmeDto
{
    
    [Required(ErrorMessage = "O titulo do filme é obrigatório ")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O titulo do filme é obrigatório ")]
    [StringLength(50, ErrorMessage = "O tamanho nao pode execeder 50 caracteres")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "O Duracao do filme é obrigatório ")]
    [Range(70, 600, ErrorMessage = "A duracao deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }

}

