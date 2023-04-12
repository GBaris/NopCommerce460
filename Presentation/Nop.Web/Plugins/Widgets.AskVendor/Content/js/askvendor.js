//$(document).ready(function () {
//  console.log("Document ready");
//  $(".modaal").modaal();
//  console.log("Modaal plugin initialized");

//  var form = $("#ask-vendor-form");
//  console.log("Form selected:", form);

//  form.on("submit", function (event) {
//    console.log("Form submit event triggered");
//    event.preventDefault(); // Varsayılan form gönderme işlemini önle
//    console.log("Default form submit prevented");

//    // Form verilerini al ve bir AJAX isteği ile gönder
//    $.ajax({
//      url: form.attr("action"), // Formun "asp-action" özelliğinde belirtilen URL'ye istek yap
//      method: "POST", // POST metodu kullan
//      data: form.serialize(), // Form verilerini serialize et
//      beforeSend: function () {
//        console.log("AJAX request about to be sent");
//      },
//      success: function () {
//        console.log("Form başarıyla gönderildi");
//        // İsteğe bağlı olarak sayfayı yönlendir, mesaj göster, vb.
//      },
//      error: function (error) {
//        console.error("Form gönderilirken hata oluştu:", error);
//      },
//      complete: function () {
//        console.log("AJAX request completed");
//      },
//    });
//  });
//});
