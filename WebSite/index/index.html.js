// ملف JavaScript لـ XStore مع التفاعلات المُحسّنة

document.addEventListener("DOMContentLoaded", () => {
    // إضافة تأثير عند تمرير الصفحة على الهيدر
    const header = document.querySelector("header");
    window.addEventListener("scroll", () => {
        if (window.scrollY > 50) {
            header.classList.add("shadow-lg", "sticky", "top-0", "bg-opacity-90", "backdrop-blur");
        } else {
            header.classList.remove("shadow-lg", "sticky", "top-0", "bg-opacity-90", "backdrop-blur");
        }
    });

    // تأثير تحميل البرنامج
    const downloadButton = document.querySelector("a.bg-blue-600");
    if (downloadButton) {
        downloadButton.addEventListener("click", (event) => {
            event.preventDefault();
            downloadButton.disabled = true; // تعطيل الزر مؤقتًا
            downloadButton.classList.add("animate-pulse");
            setTimeout(() => {
                alert("جاري تحميل البرنامج... شكراً لاختيار XStore!");
                downloadButton.classList.remove("animate-pulse");
                downloadButton.disabled = false; // إعادة تفعيل الزر
                window.location.href = downloadButton.href;
            }, 1500);
        });
    }

    // تفعيل الوضع الداكن تلقائيًا بناءً على الوقت
    const hour = new Date().getHours();
    if (hour >= 18 || hour < 6) {
        document.documentElement.classList.add("dark");
    }

    // تمرير ناعم للنقرات على الروابط
    document.querySelectorAll('a[href^="#"]').forEach((anchor) => {
        anchor.addEventListener("click", function (e) {
            e.preventDefault();
            document.querySelector(this.getAttribute("href")).scrollIntoView({
                behavior: "smooth",
            });
        });
    });

    // تأثيرات البطاقات عند تمرير الماوس
    const cards = document.querySelectorAll(".grid .bg-white");
    cards.forEach((card) => {
        card.addEventListener("mouseenter", () => {
            card.classList.add("transform", "scale-105", "shadow-xl", "transition", "duration-500");
        });
        card.addEventListener("mouseleave", () => {
            card.classList.remove("transform", "scale-105", "shadow-xl");
        });
    });

    // تأثير الكتابة التلقائية على النصوص
    const typeEffect = (element, text, delay = 100) => {
        element.textContent = "";
        let i = 0;
        const interval = setInterval(() => {
            if (i < text.length) {
                element.textContent += text[i];
                i++;
            } else {
                clearInterval(interval);
            }
        }, delay);
    };

    const welcomeText = document.querySelector("h1.text-3xl");
    if (welcomeText) {
        const text = welcomeText.textContent;
        typeEffect(welcomeText, text, 80);
    }

    // رسالة تفاعلية عند النقر على رابط المجتمع
    const communityLink = document.querySelector("a[href='https://discord.gg/pQSsZcNF']");
    if (communityLink) {
        communityLink.addEventListener("click", (event) => {
            event.preventDefault();
            communityLink.classList.add("text-green-500", "font-bold");
            setTimeout(() => {
                alert("انضم إلى مجتمعنا واستمتع بالتفاعل مع اللاعبين!");
                communityLink.classList.remove("text-green-500", "font-bold");
                window.location.href = communityLink.href;
            }, 1000);
        });
    }

    // تحسين تنبيه التحميل التلقائي
    const alertOnDownload = () => {
        const downloadLink = document.querySelector("a.bg-blue-600");
        if (downloadLink) {
            downloadLink.addEventListener("mouseover", () => {
                downloadLink.setAttribute("title", "اضغط لتحميل البرنامج الآن!");
            });
        }
    };
    alertOnDownload();
});
