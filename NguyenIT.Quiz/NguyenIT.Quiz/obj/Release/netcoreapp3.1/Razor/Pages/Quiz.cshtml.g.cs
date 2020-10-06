#pragma checksum "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "574a2abe1c017491e679e4757e9d4b58ab7dc8cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NguyenIT.Quiz.Pages.Pages_Quiz), @"mvc.1.0.razor-page", @"/Pages/Quiz.cshtml")]
namespace NguyenIT.Quiz.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\_ViewImports.cshtml"
using NguyenIT.Quiz;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"574a2abe1c017491e679e4757e9d4b58ab7dc8cc", @"/Pages/Quiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bded5ee7c654a4fd01d256814291a4459014cae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Quiz : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"text-center\">");
#nullable restore
#line 4 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
                   Write(Model.GetTitle(Model.Year, Model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Năm ");
#nullable restore
#line 4 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
                                                                   Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p class=\"text-center mb-3\">Tổng số câu hỏi: <strong>");
#nullable restore
#line 5 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
                                                Write(Model.Quizs.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n");
#nullable restore
#line 7 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
 foreach (var quiz in Model.Quizs)
{

    int maxCount = 4;
    if (string.IsNullOrEmpty(quiz.D))
        maxCount = 3;
    else if (string.IsNullOrEmpty(quiz.C))
        maxCount = 2;
    else if (string.IsNullOrEmpty(quiz.B))
        maxCount = 1;
    Random random = new Random();
    int correct = random.Next(0, maxCount);
    //if (correct == 4)
    //{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"mt-4\">");
#nullable restore
#line 22 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
                 Write(quiz.Id+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 22 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
                              Write(quiz.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 23 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
    if (!string.IsNullOrEmpty(quiz.A))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
   Write(await Html.PartialAsync("QuestionAnswer", new { Id = "A" + quiz.Id, Name = quiz.Id, Text = quiz.A }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
                                                                                                             

    }
    if (!string.IsNullOrEmpty(quiz.B))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
   Write(await Html.PartialAsync("QuestionAnswer", new { Id = "B" + quiz.Id, Name = quiz.Id, Text = quiz.B }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
                                                                                                             

    }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
         
    if (!string.IsNullOrEmpty(quiz.C))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
   Write(await Html.PartialAsync("QuestionAnswer", new { Id = "C" + quiz.Id, Name = quiz.Id, Text = quiz.C }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
                                                                                                             

    }
    if (!string.IsNullOrEmpty(quiz.D))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
   Write(await Html.PartialAsync("QuestionAnswer", new { Id = "D" + quiz.Id, Name = quiz.Id, Text = quiz.D }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
                                                                                                             

    }
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n    var arrayOfArrays = JSON.parse(\'");
#nullable restore
#line 47 "E:\Projects\onthithanhocvien\NguyenIT.Quiz\NguyenIT.Quiz\Pages\Quiz.cshtml"
                               Write(Html.Raw(Json.Serialize(Model.Quizs)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
    $(document).ready(function () {
        $('input[type=radio]').click(function (e) {
            console.log(this.id);
            var answer = this.id.substr(0, 1);
            var id = this.id.replace(answer, '');
            console.log(answer);
            console.log(id);
            console.log(arrayOfArrays[Number(id)]);
            if (arrayOfArrays[Number(id)].answer == answer.toLowerCase()) {
                $(this).parent().addClass(""bg-success"");
            }
            else {

                $(this).parent().addClass(""bg-danger"");
                $('#' + Number(id) + arrayOfArrays[Number(id)].answer).parent().addClass(""bg-primary"");
            }
        });
    });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NguyenIT.Quiz.Pages.QuizModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NguyenIT.Quiz.Pages.QuizModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NguyenIT.Quiz.Pages.QuizModel>)PageContext?.ViewData;
        public NguyenIT.Quiz.Pages.QuizModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591