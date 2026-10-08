/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ['./Views/**/*.cshtml', './Areas/**/*.cshtml', './wwwroot/js/**/*.js'],
  theme: {
    extend: {
      colors: {
        ruby: '#550000',
        crimson: '#8f0a0a',
        primary: '#d61f1f',
        flame: '#ff3b30',
        gold: '#b8860b',
        darkbg: '#0a0505'
      },
      fontFamily: { sans: ['Inter', 'sans-serif'] },
      animation: {
        'marquee': 'marquee 30s linear infinite',
        'shimmer': 'shimmer 2s infinite',
      },
      keyframes: {
        marquee: {
          '0%': { transform: 'translateX(0%)' },
          '100%': { transform: 'translateX(-50%)' },
        },
        shimmer: {
          '100%': { transform: 'translateX(100%)' },
        }
      }
    }
  },
  plugins: []
};
