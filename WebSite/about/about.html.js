/* تأثير fadeIn عند التمرير */
.fadeIn {
    opacity: 1;
    transform: translateY(0);
    transition: opacity 0.5s ease - out, transform 0.5s ease - out;
}

/* قبل ظهور العناصر، ستكون مخفية */
.invisible {
    opacity: 0;
    transform: translateY(30px);
}

/* تأثير للظهور عند التمرير */
.fade -in {
    opacity: 1;
    transform: translateY(0);
    transition: opacity 0.6s ease- out, transform 0.6s ease - out;
}

/* تأثير عند مرور الفأرة على العناصر */
.hover - effect {
    transition: transform 0.3s ease, box - shadow 0.3s ease;
}

.hover - effect.hovered {
    transform: scale(1.05);
    box - shadow: 0 4px 12px rgba(0, 0, 0, 0.2);
}

/* تأثير الرسالة المنبثقة */
.popup - message {
    position: absolute;
    top: 20 %;
    left: 50 %;
    transform: translateX(-50 %);
    background - color: #1D4ED8;
    color: white;
    padding: 15px 30px;
    border - radius: 8px;
    font - size: 1rem;
    box - shadow: 0 4px 10px rgba(0, 0, 0, 0.3);
    z - index: 1000;
    animation: popupAnimation 3s ease - out;
}

@keyframes popupAnimation {
    0 % { opacity: 0; top: 10 %; }
    50 % { opacity: 1; top: 20 %; }
    100 % { opacity: 0; top: 30 %; }
}

/* تخصيص الأزرار للتمرير السلس */
a {
    color: var(--secondary - color);
    text - decoration: none;
}

a:hover {
    text - decoration: underline;
}
