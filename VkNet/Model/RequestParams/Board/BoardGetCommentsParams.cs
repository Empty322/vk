﻿using System;
using Newtonsoft.Json;
using VkNet.Enums.SafetyEnums;
using VkNet.Utils;

namespace VkNet.Model.RequestParams
{
    /// <summary>
    /// Параметры метода board.getTopics
    /// </summary>
    [Serializable]
    public class BoardGetCommentsParams
    {
		/// <summary>
		/// Идентификатор владельца страницы (пользователь или сообщество). Обратите внимание, идентификатор сообщества в параметре owner_id необходимо указывать со знаком "-" — например, owner_id=-1 соответствует идентификатору сообщества ВКонтакте API (club1)  целое число, по умолчанию идентификатор текущего пользователя.
		/// </summary>
		[JsonProperty("group_id")]
		public long? GroupId { get; set; }

        /// <summary>
        /// Идентификатор обсуждения.Положительное число, обязательный параметр.
        /// </summary>
        [JsonProperty("topic_id")]
        public long TopicId { get; set; }

        /// <summary>
		/// 1 — возвращать информацию о лайках. флаг, может принимать значения 1 или 0.
		/// </summary>
        [JsonProperty("need_likes")]
		public bool? NeedLikes { get; set; }

        /// <summary>
        /// Идентификатор комментария, начиная с которого нужно вернуть список (подробности см. ниже). положительное число, доступен начиная с версии 5.33.
        /// </summary>
        [JsonProperty("start_comment_id")]
        public long? StartCommentId { get; set; }

        /// <summary>
        /// Сдвиг, необходимый для получения конкретной выборки результатов. целое число.
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// Число комментариев, которые необходимо получить. По умолчанию — 10, максимальное значение — 100. положительное число.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// Порядок сортировки комментариев (asc — от старых к новым, desc - от новых к старым) строка.
        /// </summary>
        [JsonProperty("sort")]
        public CommentsSort Sort { get; set; }

        /// <summary>
        /// Количество символов, по которому нужно обрезать текст комментария. Укажите 0, если Вы не хотите обрезатьтекст. положительное число.
        /// </summary>
        [JsonProperty("preview_length")]
        public long? PreviewLength { get; set; }

        /// <summary>
        /// 1 — комментарии в ответе будут возвращены в виде пронумерованных объектов, дополнительно будут возвращены списки объектов profiles, groups. флаг, может принимать значения 1 или 0, доступен начиная с версии 5.0.
        /// </summary>
        [JsonProperty("extended")]
        public bool? Extended { get; set; }

        /// <summary>
        /// Привести к типу VkParameters.
        /// </summary>
        /// <param name="p">Параметры.</param>
        /// <returns></returns>
        public static VkParameters ToVkParameters(BoardGetCommentsParams p)
		{
			var parameters = new VkParameters
			{
                { "group_id", p.GroupId },
                { "topic_id", p.TopicId },
                { "need_likes", p.NeedLikes },
                { "start_comment_id", p.StartCommentId },
                { "offset", p.Offset },
                { "count", p.Count },
                { "sort", p.Sort },
                { "preview_length", p.PreviewLength },
                { "extended", p.Extended }
            };

			return parameters;
		}
	}
}