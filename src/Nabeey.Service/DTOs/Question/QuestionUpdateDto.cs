﻿using Microsoft.AspNetCore.Http;

namespace Nabeey.Service.DTOs.Question;

public class QuestionUpdateDto
{
    public long Id { get; set; }
	public string Text { get; set; }
	public IFormFile File { get; set; }
}
