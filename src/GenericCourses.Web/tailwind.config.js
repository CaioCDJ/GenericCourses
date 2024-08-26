/** @type {import('tailwindcss').Config} */
module.exports = {
	content: [
		'./Pages/**/*.cshtml',
		'./Views/**/*.cshtml',
	],
	theme: {
		extend: {},
	},
	plugins: [
		// require('flowbite/plugin')
		require("daisyui")
	],
	daisyui: {
		styled: true,
		base: true,
		utils: true,
		logs: true,
		rtl: false,
		themes: [
			{
				mytheme: {
					primary: "#0369a1",
					secondary: "#1e3a8a",
					accent: "#00c1ca",
					neutral: "#d2d2d2",
					"base-100": "#111827",
					"base-200": "#0D192B",
					"base-300": "#09192F",
					info: "#00aaff",
					success: "#00ed81",
					warning: "#f9b900",
					error: "#cc0035",
				}
			},
		],
	},
}

